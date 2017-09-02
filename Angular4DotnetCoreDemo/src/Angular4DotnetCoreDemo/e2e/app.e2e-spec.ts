import { Angular4DeepPage } from './app.po';

describe('angular4-deep App', () => {
  let page: Angular4DeepPage;

  beforeEach(() => {
    page = new Angular4DeepPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
